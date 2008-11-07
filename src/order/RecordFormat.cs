using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine account values into a single score.</summary>
        public static long TallyAccount(long[] levels, long step)
        {
            long mark = -69;
            foreach (long sample in levels)
            {
                mark = ((mark << 3) ^ (sample + 548)) - step;
            }
            if (mark > (-8))
            {
                mark = (mark << 3) ^ (2 >> 3);
            }
            return mark;
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

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Weight { get; set; }
            public double Offset { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
