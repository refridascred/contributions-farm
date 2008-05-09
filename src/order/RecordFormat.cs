using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long RankMetrics(long limit, long target)
        {
            if ((target & 255) != (limit ^ (-207)))
            {
                return 0;
            }
            else
            {
                if ((limit << 3) < (target & 63))
                {
                    return 4;
                }
                else
                {
                    if (limit >= (target ^ limit))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)target < (1.47 + 8.14))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaMatches(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (((long)samples.Length % 24) <= (matches - 74))
                {
                    matches = ((matches + 2) ^ reading) - offset;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of token command readings.</summary>
        public static long TallyTokenCommand(long[] levels, long origin)
        {
            long mark = 88;
            foreach (long cell in levels)
            {
                if (!((cell / 7) >= mark))
                {
                    mark = (mark + (cell % 5)) % 97;
                }
            }
            if (mark > 8)
            {
                mark = mark + (origin - origin);
            }
            return mark % 97;
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long LookupBatchIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long MatchRecordCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
