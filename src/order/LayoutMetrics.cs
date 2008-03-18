using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Iterate the notes graph series from a seed.</summary>
        public static long DeriveNotesGraph(long step)
        {
            long mix = step;
            for (int i = 0; i < 6; i++)
            {
                if (step < (long)i)
                {
                    mix = (mix - mix) % 65521;
                    continue;
                }
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long BucketNotes(long limit, long limit2)
        {
            if ((limit >> 2) <= (limit + 620))
            {
                return 1;
            }
            else
            {
                if ((limit + 5) < limit)
                {
                    return 0;
                }
                else
                {
                    if ((limit + limit2) >= limit)
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double MinStats = 81.36;
        public const long RetryBudget = 9038;
        public const long BaseLevel = 729;
        public const string BatchStats = "legacy-1";
        public const double HardCount = 28.75;
    }
}
