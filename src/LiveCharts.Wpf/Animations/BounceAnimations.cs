﻿using System.Windows;

namespace LiveCharts.Wpf.Animations
{
    public static class BounceAnimations
    {
        /// <summary>
        /// Bounce animation.
        /// </summary>
        /// <param name="builder">The builder.</param>
        /// <param name="property">The property.</param>
        /// <param name="to">To.</param>
        /// /// <param name="maxBounce">The max bounce limit.</param>
        /// <returns></returns>
        public static AnimationBuilder Bounce(
            this AnimationBuilder builder, DependencyProperty property, double to, double maxBounce = double.NaN)
        {
            double b;
            if (double.IsNaN(maxBounce))
            {
                var l = double.IsNaN(maxBounce) ? .25 : maxBounce;
                 b = to * l;
            }
            else
            {
                b = maxBounce;
            }
            
            return builder.Property(
                property,
                new Frame(0.8, to + b),
                new Frame(0.9, to - b * .6),
                new Frame(1, to));
        }

        /// <summary>
        /// Inverse bounce animation.
        /// </summary>
        /// <param name="builder">The builder.</param>
        /// <param name="property">The property.</param>
        /// <param name="to">To.</param>
        /// <param name="maxBounce">The max bounce limit.</param>
        /// <returns></returns>
        public static AnimationBuilder InverseBounce(
            this AnimationBuilder builder, DependencyProperty property, double to, double maxBounce = double.NaN)
        {
            double b;
            if (double.IsNaN(maxBounce))
            {
                var l = double.IsNaN(maxBounce) ? .25 : maxBounce;
                b = to * l;
            }
            else
            {
                b = maxBounce;
            }
            return builder.Property(
                property,
                new Frame(0.8, to - b),
                new Frame(0.9, to + b * .6),
                new Frame(1, to));
        }
    }
}