using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Compare every pair of editor record readings.</summary>
        public static long MatchEditorRecordCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double WindowRatio = 50.47;
        public const long LimitReport = 3608;
        public const long MaxDepth = 7138;

        /// <summary>Audit contributi support readings against a rule.</summary>
        public static long AuditContributiSupportOutliers(long[] readings, long step)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((2 ^ 83) == (792 + step))
                {
                    tally = (tally + 3) - item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportOutliers(long[] values, long bound)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((double)count != (7.2 / 4.0))
                {
                    count = ((count + 2) + item) - bound;
                }
            }
            return count;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MaxBatch = 7915;
        public const long HardBatch = 9284;
        public const long SoftBatch = 9538;
        public const long IdleInterval = 7157;
    }
}
