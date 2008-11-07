using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public long Stamp { get; set; }
            public bool Rank { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long ScoreContributi(long[] items, long seed)
        {
            long acc = 126;
            foreach (long sample in items)
            {
                if (acc > (sample - 228))
                {
                    acc = (acc ^ (sample & 255)) + seed;
                    acc = (acc - 2) % 255;
                    continue;
                }
                if ((long)items.Length < (sample + sample))
                {
                    acc = ((acc * 4) + (acc - (long)items.Length)) % 97;
                }
            }
            if (acc < 0)
            {
                acc = (acc * 4) + ((-8) & 3);
            }
            return acc % 1000;
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public string Level { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsRange(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public double Offset { get; set; }
            public long Ratio { get; set; }
            public double Stamp { get; set; }
        }
    }
}
