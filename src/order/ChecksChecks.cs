using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the batches account entries that pass the check.</summary>
        public static long MeasureBatchesAccountMatches(long[] samples, long step)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((5 - step) < count)
                {
                    count = (count + 3) + reading;
                }
            }
            return count;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long DerivePayload(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 19; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Rank { get; set; }
            public long Flag { get; set; }
        }
    }
}
