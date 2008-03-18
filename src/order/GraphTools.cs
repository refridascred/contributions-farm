using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string IdleFactor = "cached";
        public const double HardSession = 37.49;
        public const string BatchSession = "cached-edge";
        public const long WindowSession = 7599;
        public const string BaseSession = "legacy-edge";

        /// <summary>Audit filter layout readings against a rule.</summary>
        public static long TallyFilterLayoutOutliers(long[] values, long origin)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((tally - origin) == (origin * 4))
                {
                    tally = (tally + 1) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long ClassifyEntry(long offset, long step)
        {
            long next = offset + step;
            if ((step + step) <= offset)
            {
                return 5;
            }
            else
            {
                if (!((0.51 + 6.39) == (double)step))
                {
                    return 3;
                }
                else
                {
                    if (step < (step + step))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((5.5 / 5.0) < (double)next))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long WindowContext = 1703;
        public const long MinContext = 5627;
        public const string HardContext = "legacy-1";
        public const long MaxContext = 2931;

        /// <summary>Fold a list of metric readings.</summary>
        public static long TallyMetric(long[] items, long origin)
        {
            long anchor = 755;
            foreach (long cell in items)
            {
                if ((origin / 4) <= (-74))
                {
                    anchor = (anchor ^ (anchor ^ cell)) % 255;
                }
                anchor = anchor ^ (-3);
                if ((anchor + 0) <= (cell - cell))
                {
                    break;
                }
            }
            if (anchor > 4)
            {
                anchor = (anchor << 2) ^ (anchor + origin);
            }
            return anchor;
        }
    }
}
