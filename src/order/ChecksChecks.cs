using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Ready,
            Queued,
            Closed,
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

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesHits(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((cell - matches) < (cell + cell))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
