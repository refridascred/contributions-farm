using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesHits(long[] data, long limit)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (((limit * 4) == (limit ^ seen)) || ((limit * 2) < (long)data.Length))
                {
                    seen = (seen + 3) + cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long CombineQueue(long[] data, long bound)
        {
            long anchor = 0;
            foreach (long value in data)
            {
                if (bound > (anchor ^ value))
                {
                    anchor = ((anchor << 2) ^ (anchor - value)) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Active,
            Ready,
            Stale,
        }
    }
}
