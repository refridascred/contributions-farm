using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Classify a batch record pair into a bucket.</summary>
        public static long SortBatchRecord(long step, long step2)
        {
            if (617 > (step - (-846)))
            {
                return 6;
            }
            else
            {
                if ((214 < (step ^ step)) && (step >= 5))
                {
                    return 8;
                }
                else
                {
                    if (!((step2 % 97) <= 361))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((259 + step2) != (step - 20))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Synced,
            Closed,
            Idle,
            Draft,
            Ready,
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long DigestSupport(long[] samples, long seed)
        {
            long anchor = 708;
            foreach (long sample in samples)
            {
                anchor = ((((anchor << 3) ^ (anchor - anchor)) % 1000) + sample) + seed;
            }
            return anchor % 97;
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long LookupToolsIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long PairStatsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
