﻿using Uno.Extensions;
using Uno.Foundation.Logging;
using Uno.UI.Controls;
using Uno.UI.Helpers;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using Android.Views;
using Uno.UI.DataBinding;
using Uno.Disposables;
using Windows.UI.Xaml.Data;
using System.Runtime.CompilerServices;
using Android.Graphics;
using Android.Graphics.Drawables;
using Uno.UI;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls
{
	public partial class Panel : IEnumerable
	{
		private WeakBrushChangedProxy _backgroundBrushChangedProxy;
		private Action _backgroundBrushChanged;

		private WeakBrushChangedProxy _borderBrushChangedProxy;
		private Action _borderBrushChanged;
		private BorderLayerRenderer _borderRenderer = new BorderLayerRenderer();

		public Panel()
		{
			Initialize();
		}

		~Panel()
		{
			_backgroundBrushChangedProxy?.Unsubscribe();
			_borderBrushChangedProxy?.Unsubscribe();
		}

		protected override void JavaFinalize()
		{
			_backgroundBrushChangedProxy?.Unsubscribe();
			_borderBrushChangedProxy?.Unsubscribe();
			base.JavaFinalize();
		}

		protected override void OnChildViewAdded(View child)
		{
			if (child is IFrameworkElement element)
			{
				OnChildAdded(element);
			}

			base.OnChildViewAdded(child);
		}

		partial void Initialize();

		partial void OnLoadedPartial()
		{
			UpdateBorder();
		}

		partial void OnUnloadedPartial()
		{
			_borderRenderer.Clear();
		}

		partial void UpdateBorder()
		{
			UpdateBorder(false);
		}

		private void UpdateBorder(bool willUpdateMeasures)
		{
			if (IsLoaded)
			{
				_borderRenderer.UpdateLayer(
					this,
					Background,
					InternalBackgroundSizing,
					BorderThicknessInternal,
					BorderBrushInternal,
					CornerRadiusInternal,
					PaddingInternal,
					willUpdateMeasures
				);
			}
		}

		protected override void OnLayoutCore(bool changed, int left, int top, int right, int bottom, bool localIsLayoutRequested)
		{
			base.OnLayoutCore(changed, left, top, right, bottom, localIsLayoutRequested);

			UpdateBorder(changed);
		}

		protected override void OnDraw(Android.Graphics.Canvas canvas)
		{
			AdjustCornerRadius(canvas, CornerRadiusInternal);
		}

		protected virtual void OnChildrenChanged()
		{
			UpdateBorder();
		}

		partial void OnPaddingChangedPartial(Thickness oldValue, Thickness newValue)
		{
			UpdateBorder(true);
		}

		partial void OnBorderBrushChangedPartial(Brush oldValue, Brush newValue)
		{
			_borderBrushChangedProxy ??= new();
			_borderBrushChanged ??= () => UpdateBorder();
			_borderBrushChangedProxy.Subscribe(newValue, _borderBrushChanged);
		}

		partial void OnBorderThicknessChangedPartial(Thickness oldValue, Thickness newValue)
		{
			UpdateBorder();
		}

		partial void OnCornerRadiusChangedPartial(CornerRadius oldValue, CornerRadius newValue)
		{
			UpdateBorder();
		}

		protected override void OnBackgroundChanged(DependencyPropertyChangedEventArgs e)
		{
			// Don't call base, just update the filling color.
			_backgroundBrushChangedProxy ??= new();
			_backgroundBrushChanged ??= () => UpdateBorder();
			_backgroundBrushChangedProxy.Subscribe(e.NewValue as Brush, _backgroundBrushChanged);
		}

		protected override void OnBeforeArrange()
		{
			base.OnBeforeArrange();

			//We set childrens position for the animations before the arrange
			_transitionHelper?.SetInitialChildrenPositions();
		}

		protected override void OnAfterArrange()
		{
			base.OnAfterArrange();

			//We trigger all layoutUpdated animations
			_transitionHelper?.LayoutUpdatedTransition();
		}

		/// <summary>        
		/// Support for the C# collection initializer style.
		/// Allows items to be added like this 
		/// new Panel 
		/// {
		///    new Border()
		/// }
		/// </summary>
		/// <param name="view"></param>
		public void Add(UIElement view)
		{
			Children.Add(view);
		}

		public IEnumerator GetEnumerator()
		{
			return this.GetChildren().GetEnumerator();
		}

		bool ICustomClippingElement.AllowClippingToLayoutSlot => true;
		bool ICustomClippingElement.ForceClippingToLayoutSlot => CornerRadiusInternal != CornerRadius.None;
	}
}
