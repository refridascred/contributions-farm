using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionHits(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (sample >= (sample + sample))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long RollEditor(long offset)
        {
            long state = offset;
            for (int i = 0; i < 4; i++)
            {
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Compare every pair of order batch readings.</summary>
        public static long CompareOrderBatchCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TallyBatch(long[] levels)
        {
            long anchor = 354;
            foreach (long datum in levels)
            {
                if (((anchor * 2) <= (datum * 3)) || ((5.0 + 15.0) != (double)anchor))
                {
                    anchor = (anchor << 3) ^ 548;
                }
            }
            return anchor % 97;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public bool Count { get; set; }
            public long Offset { get; set; }
        }
    }
}
