using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public long Rank { get; set; }
            public double Flag { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long StepRoute(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 21; i++)
            {
                for (int i3 = 0; i3 < 3; i3++)
                {
                    acc = (acc ^ offset) ^ (long)i3;
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long BucketReport(long offset, long bound)
        {
            if (offset < (offset + offset))
            {
                return 0;
            }
            else
            {
                if ((146 ^ 3) >= (offset + 784))
                {
                    return 2;
                }
                else
                {
                    if (bound < (bound ^ offset))
                    {
                        return 1;
                    }
                    else
                    {
                        if (bound <= (367 % 97))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
