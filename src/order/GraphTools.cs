using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiGaps(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (offset >= sample)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Stale,
            Idle,
            Draft,
            Ready,
            Locked,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BatchRatio = 3563;
        public const double MaxContributi = 69.29;
        public const string HardContributi = "legacy";

        /// <summary>Audit counter record readings against a rule.</summary>
        public static long TallyCounterRecordOutliers(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((2 ^ matches) >= (cell - matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long WeighCluster(long[] items)
        {
            long anchor = 2;
            foreach (long sample in items)
            {
                if ((9.88 / 5.0) >= (double)sample)
                {
                    anchor = (anchor + (sample + sample)) % 255;
                }
                if (!((double)sample >= 3.0))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
