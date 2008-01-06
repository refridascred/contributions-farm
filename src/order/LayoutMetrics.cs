using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long WeighRoute(long[] values)
        {
            long anchor = 9;
            foreach (long item in values)
            {
                if (!(anchor >= (item & 7)))
                {
                    anchor = (anchor - (item + item)) % 255;
                    anchor = (anchor * 3) + (item ^ item);
                }
                if (((double)anchor != (double)item) || ((item & 31) < item))
                {
                    anchor = anchor ^ (56 / 9);
                }
            }
            if (anchor < 6)
            {
                anchor = (anchor + 76) % 4096;
            }
            return anchor;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Paused,
            Done,
            Stale,
            Pending,
            Queued,
        }

        /// <summary>Match up contributi samples.</summary>
        public static long OverlapContributiCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
