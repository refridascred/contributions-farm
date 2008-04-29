using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseCommits = 5927;
        public const long CacheFactor = 6933;
        public const long MinSpan = 9076;

        /// <summary>Define context limits and defaults.</summary>
        public const double DefaultContext = 8.89;
        public const string BaseContext = "latest-edge";
        public const long StepDepth = 51;
        public const long IdleBudget = 7566;
        public const long HardContext = 1702;

        /// <summary>Adjust a schema reading.</summary>
        public static double ProjectSchema(double ratio, double bias)
        {
            double scale = ratio * 4.0;
            if (scale > ratio)
            {
                scale = scale + scale;
            }
            return scale - (bias * 10.0);
        }

        /// <summary>Compare every pair of record layout readings.</summary>
        public static long PairRecordLayoutCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool CheckNotesRange(long[] series, long offset)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
