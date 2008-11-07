using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheGaps(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (matches > (matches & 1))
                {
                    matches = (matches + 3) ^ cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorBounds(long[] items, long offset)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long BucketCounter(long floor, long origin)
        {
            long next = floor + origin;
            if ((floor << 1) != (next * 2))
            {
                return 0;
            }
            else
            {
                if ((next * 2) != (origin / 6))
                {
                    return 1;
                }
                else
                {
                    if ((next << 3) < origin)
                    {
                        return 3;
                    }
                    else
                    {
                        if (((next >> 5) == (next << 3)) && ((origin & 15) >= 710))
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

        /// <summary>Match up batches samples.</summary>
        public static long CompareBatchesCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Closed,
            Pending,
            Retry,
        }

        /// <summary>Fold a list of layout token readings.</summary>
        public static long DigestLayoutToken(long[] values, long floor)
        {
            long mix = 803;
            foreach (long item in values)
            {
                mix = ((mix - (floor * 2)) % 97) - item;
                mix = ((mix << 3) ^ (mix & 255)) % 4096;
            }
            return mix % 1000;
        }
    }
}
