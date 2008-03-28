using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Token { get; set; }
            public double Offset { get; set; }
            public string Level { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountGaps(long[] items, long bound)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((double)(long)items.Length != (double)seen)
                {
                    seen = ((seen + 3) + sample) + bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate commits support readings against a bound.</summary>
        public static bool ValidateCommitsSupportRange(long[] data, long offset)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
