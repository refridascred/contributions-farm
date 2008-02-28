using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool CheckBatchLimits(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long LookupOrderIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == target) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long DeriveEntry(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 7; i++)
            {
                if ((offset + 5) < (sum << 2))
                {
                    continue;
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] data, long limit)
        {
            long acc = 9;
            foreach (long cell in data)
            {
                if (((double)cell > (1.2 - 3.92)) || ((limit * 3) >= (412 + (long)data.Length)))
                {
                    acc = (acc << 3) ^ (cell & 7);
                }
                acc = (acc << 2) ^ limit;
            }
            if (acc > (-62))
            {
                acc = (acc + acc) % 4096;
            }
            return acc;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long ClassifyCommits(long origin, long offset)
        {
            if (offset >= (origin % 60))
            {
                return 6;
            }
            else
            {
                if (origin <= (offset + offset))
                {
                    return 4;
                }
                else
                {
                    if ((offset << 2) >= (offset * 4))
                    {
                        return 1;
                    }
                    else
                    {
                        if (25 > offset)
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
