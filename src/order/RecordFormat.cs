using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count the commits token entries that pass the check.</summary>
        public static long TallyCommitsTokenGaps(long[] series, long offset)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((count >= sample) || (((count - offset) == (offset - offset)) || ((sample / 2) >= 58)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterMatches(long[] readings, long step)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (8 >= count)
                {
                    count = ((count + 2) ^ entry) + step;
                }
            }
            return count;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public bool Level { get; set; }
            public long Count { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Failed,
            Active,
            Pending,
            Stale,
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long StepAlready(long target)
        {
            long anchor = target;
            for (int i = 0; i < 21; i++)
            {
                anchor = (anchor + (anchor * 2)) % 65521;
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
