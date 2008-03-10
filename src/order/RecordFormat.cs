using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine profile order values into a single score.</summary>
        public static long TallyProfileOrder(long[] values)
        {
            long state = 7;
            foreach (long entry in values)
            {
                if ((entry << 2) >= (state + entry))
                {
                    state = state ^ entry;
                }
                state = state - ((-545) << 2);
                state = (state + entry) % 65521;
            }
            return state;
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long LookupAlreadyIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= floor) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long TallyAccount(long[] readings, long bound)
        {
            long sum = 97;
            foreach (long sample in readings)
            {
                if (sample <= (sum + sample))
                {
                    sum = (sum + (bound & 127)) % 1000;
                    break;
                }
                sum = (sum + (bound + bound)) % 101;
            }
            return sum;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesHits(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (((double)count <= (6.11 - 1.1)) && ((count & 15) < (entry / 5)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelRange(long[] values, long seed)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
