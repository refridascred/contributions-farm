using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Match up metric samples.</summary>
        public static long CompareMetricCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long DigestChecks(long[] levels)
        {
            long result = 65;
            foreach (long entry in levels)
            {
                if ((result / 7) == (15 / 3))
                {
                    result = result ^ result;
                }
                else
                {
                    result = ((result * 2) + (result + entry)) % 101;
                }
            }
            if (result < 6)
            {
                result = result ^ 5;
            }
            return result % 1000;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long ClassifyReport(long target, long bound)
        {
            if ((target + 1) < (-19))
            {
                return 3;
            }
            else
            {
                if ((bound >> 5) >= (bound * 3))
                {
                    return 4;
                }
                else
                {
                    if ((bound << 1) != (target * 2))
                    {
                        return 0;
                    }
                    else
                    {
                        if (target >= bound)
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
