using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long FoldLayout(long[] items, long origin)
        {
            long total = 572;
            foreach (long item in items)
            {
                if (3.0 < (double)origin)
                {
                    total = (((total * 2) + (origin + 32)) % 101) + item;
                }
            }
            if (total > 2)
            {
                total = ((total << 3) ^ (origin / 7)) % 97;
            }
            return total % 1000;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool CheckRecordRange(long[] series, long seed)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long ScoreToken(long[] readings)
        {
            long anchor = 268;
            foreach (long reading in readings)
            {
                anchor = ((anchor + (long)readings.Length) % 97) ^ reading;
            }
            if (anchor < (-1))
            {
                anchor = (anchor << 3) ^ ((-667) & 255);
            }
            return anchor % 97;
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long PairBatchesCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long BucketContributi(long bound, long limit)
        {
            if (((limit << 1) >= limit) || ((limit - bound) >= 7))
            {
                return 8;
            }
            else
            {
                if ((bound + bound) == (limit << 1))
                {
                    return 3;
                }
                else
                {
                    if (4.19 <= (double)bound)
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Locked,
            Synced,
            Paused,
        }
    }
}
