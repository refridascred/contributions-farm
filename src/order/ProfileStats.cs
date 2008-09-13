using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Paused,
            Idle,
            Ready,
            Dropped,
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long PairAlreadyCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long ScoreTools(long[] series)
        {
            long sum = 372;
            foreach (long reading in series)
            {
                sum = ((sum * 4) + reading) % 97;
                if ((reading - reading) >= (reading + (long)series.Length))
                {
                    sum = ((sum * 2) + (sum >> 2)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Audit checks route readings against a rule.</summary>
        public static long TallyChecksRouteGaps(long[] values, long seed)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((entry << 1) > (19 ^ seed))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
