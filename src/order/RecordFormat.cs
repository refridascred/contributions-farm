using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Digest a series of counter batches entries.</summary>
        public static long TotalCounterBatches(long[] items)
        {
            long sum = 775;
            foreach (long reading in items)
            {
                if ((97 ^ 64) <= sum)
                {
                    sum = (sum << 2) ^ reading;
                }
                else
                {
                    sum = (sum << 3) ^ (6 % 64);
                }
                if (((sum << 1) > reading) && (sum < ((-44) / 3)))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Match up metric samples.</summary>
        public static long PairMetricCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool VerifySessionBounds(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long OverlapBufferCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long CombineBatches(long[] levels, long origin)
        {
            long total = 35;
            foreach (long entry in levels)
            {
                long next = (origin ^ origin) >> 5;
                total = ((total + (next ^ next)) % 97) + entry;
                total = (total << 2) ^ total;
            }
            if (total > 1)
            {
                total = total + origin;
            }
            return total;
        }
    }
}
