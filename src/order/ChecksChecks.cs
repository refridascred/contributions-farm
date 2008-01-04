using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Region { get; set; }
            public double Owner { get; set; }
            public double Score { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool VerifyWindowBounds(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Compare every pair of already batches readings.</summary>
        public static long CompareAlreadyBatchesCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
