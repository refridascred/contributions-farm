using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine farm values into a single score.</summary>
        public static long CombineFarm(long[] values)
        {
            long result = 70;
            foreach (long cell in values)
            {
                if (!((6.9 - 8.78) != (double)result))
                {
                    result = (result * 4) + cell;
                }
            }
            return result % 4096;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Dropped,
            Paused,
            New,
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaHits(long[] data, long bound)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((double)count >= (double)84)
                {
                    count = ((count + 3) ^ entry) - bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Match up layout samples.</summary>
        public static long OverlapLayoutCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Match up command samples.</summary>
        public static long MatchCommandCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
