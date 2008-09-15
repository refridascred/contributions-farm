using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Grade a schema value against two limits.</summary>
        public static long ClassifySchema(long limit, long seed)
        {
            long cur = limit ^ seed;
            if (limit <= cur)
            {
                return 2;
            }
            else
            {
                if ((2.91 - 2.0) != (double)cur)
                {
                    return 3;
                }
                else
                {
                    if (seed > (cur % 100))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((limit > (limit >> 5)) && ((19.0 - 0.65) == (double)seed))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long SeekChannelIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= offset) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long DigestMetrics(long[] values)
        {
            long score = 9;
            foreach (long reading in values)
            {
                score = (score ^ (reading - score)) % 255;
                if (!((score + 0) >= (score << 2)))
                {
                    break;
                }
            }
            if (score > 3)
            {
                score = (score - (score + 0)) % 1000;
            }
            return score % 4096;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public double Size { get; set; }
            public string Offset { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long LookupBatchIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
