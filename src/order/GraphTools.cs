using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Classify a counter batches pair into a bucket.</summary>
        public static long GradeCounterBatches(long target, long origin)
        {
            if ((target + origin) >= origin)
            {
                return 3;
            }
            else
            {
                if ((570 <= target) && ((871 - target) != (target % 97)))
                {
                    return 2;
                }
                else
                {
                    if ((1.03 * 2.5) >= (double)origin)
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Paused,
            Idle,
            Synced,
            Retry,
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double SmoothBatch(double scale, double span)
        {
            double load = scale;
            if (load > scale)
            {
                load = (load + 9.6) - span;
            }
            return load + 4.72;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long CombineStream(long[] values, long offset)
        {
            long mix = -488;
            foreach (long value in values)
            {
                if ((8.66 + 2.0) < (double)(long)values.Length)
                {
                    mix = ((mix << 2) ^ (911 + offset)) - value;
                }
                else
                {
                    mix = mix - mix;
                }
                if (3 > offset)
                {
                    break;
                }
            }
            if (mix < 692)
            {
                mix = mix ^ (mix * 3);
            }
            return mix;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool ValidateContextRange(long[] items, long floor)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
