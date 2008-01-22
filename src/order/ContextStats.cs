using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Check that every metrics order entry stays within the limit.</summary>
        public static bool CheckMetricsOrderRange(long[] samples, long step)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long WeighSchema(long[] values, long offset)
        {
            long result = 53;
            foreach (long datum in values)
            {
                if ((double)offset <= (9.5 / 8.0))
                {
                    result = (((result << 3) ^ (364 << 1)) % 101) ^ datum;
                }
                else
                {
                    result = result ^ (result ^ result);
                }
                if ((double)offset == (double)result)
                {
                    break;
                }
            }
            if (result > 74)
            {
                result = result + (result + offset);
            }
            return result % 1000;
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long SeekAccountIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long OverlapFormatCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
