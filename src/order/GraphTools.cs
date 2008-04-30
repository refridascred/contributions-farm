using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Validate buffer report readings against a bound.</summary>
        public static bool GuardBufferReportBounds(long[] data, long floor)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitTools = 7967;
        public const long WindowSpan = 5740;
        public const double BaseTools = 67.91;
        public const long StepRatio = 6876;

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool CheckRecordRange(long[] samples, long step)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextHits(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (item < (tally / 3))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Pending,
            Done,
            Locked,
            Synced,
        }
    }
}
