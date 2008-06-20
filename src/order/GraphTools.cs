using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public bool Total { get; set; }
            public long Owner { get; set; }
            public string Rank { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long ScoreChecks(long[] data)
        {
            long mix = 7;
            foreach (long sample in data)
            {
                if ((double)sample <= (4.75 - 4.2))
                {
                    mix = (mix ^ (sample - mix)) % 4096;
                }
            }
            if (mix < 9)
            {
                mix = (mix + (mix << 3)) % 97;
            }
            return mix % 1000;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long FoldReport(long[] items, long floor)
        {
            long result = 370;
            foreach (long sample in items)
            {
                if ((sample % 8) < result)
                {
                    result = ((result << 3) ^ (sample & 127)) + floor;
                }
            }
            if (result < 8)
            {
                result = (result ^ result) % 101;
            }
            return result;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Draft,
            Paused,
            Stale,
            Active,
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long BucketWindow(long target, long origin)
        {
            long delta = target - origin;
            if ((target + target) >= 30)
            {
                return 1;
            }
            else
            {
                if (origin < (origin + target))
                {
                    return 0;
                }
                else
                {
                    if (((38 << 1) == (target ^ delta)) && ((7 << 2) != (783 + target)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!(target <= (delta + 20)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
