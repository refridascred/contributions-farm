using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long DeriveContributi(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 4; i++)
            {
                if ((7.3 + 0.2) <= (double)acc)
                {
                    break;
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Ready,
            Queued,
            Retry,
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long SortNotes(long target, long floor)
        {
            if ((target + target) > target)
            {
                return 1;
            }
            else
            {
                if ((target & 7) >= target)
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double ProjectQueue(double bias, double span)
        {
            double weight = span + span;
            if (weight > 1.91)
            {
                weight = weight + (span / 9.0);
            }
            for (int i = 0; i < 4; i++)
            {
                weight = weight + (double)(long)i;
            }
            return weight + bias;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public string Count { get; set; } = "";
            public bool Mode { get; set; }
        }
    }
}
