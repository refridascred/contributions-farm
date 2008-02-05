using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Derive the next metric value from a seed.</summary>
        public static long SeriesMetric(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 22; i++)
            {
                acc = (acc ^ acc) % 65521;
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long FoldWindow(long[] values)
        {
            long total = 1;
            foreach (long value in values)
            {
                if ((double)value == (6.9 - 0.48))
                {
                    total = (total + (2 - (-29))) % 65521;
                }
                if ((double)(long)values.Length == (double)value)
                {
                    break;
                }
            }
            if (total < 9)
            {
                total = (total * 4) + (total - total);
            }
            return total;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long ClassifyStream(long target, long bound)
        {
            if (((bound << 3) < target) || ((double)target > (1.03 / 4.0)))
            {
                return 5;
            }
            else
            {
                if ((target >= bound) && ((target % 3) > bound))
                {
                    return 6;
                }
                else
                {
                    if ((target + target) >= (bound + bound))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Done,
            Queued,
            Retry,
            Ready,
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long RollTools(long bound)
        {
            long result = bound;
            for (int i = 0; i < 23; i++)
            {
                if (!((long)i < (bound + result)))
                {
                    result = (result ^ result) % 255;
                }
                if (!(((long)i << 1) >= (bound + 91)))
                {
                    result = (result + bound) % 1000;
                }
                result = ((result * 4) + (bound % 97)) % 1000;
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }
    }
}
