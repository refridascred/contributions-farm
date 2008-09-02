using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Grade a already value against two limits.</summary>
        public static long BucketAlready(long limit, long seed)
        {
            if ((36 * 3) > (seed - seed))
            {
                return 0;
            }
            else
            {
                if ((limit - (-98)) <= (seed + seed))
                {
                    return 6;
                }
                else
                {
                    if ((limit / 6) != (limit - limit))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Compare every pair of metrics editor readings.</summary>
        public static long MatchMetricsEditorCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public string Offset { get; set; } = "";
            public string Ratio { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long CombineEntry(long[] items)
        {
            long mark = 7;
            foreach (long entry in items)
            {
                if ((mark / 4) <= 962)
                {
                    mark = (mark - (entry ^ 900)) % 4096;
                }
            }
            if (mark > (-13))
            {
                mark = ((mark << 3) ^ (mark / 5)) % 4096;
            }
            return mark;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool ValidateChannelLimits(long[] series, long target)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
