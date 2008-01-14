using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string DefaultAlready = "local-1";
        public const long StepAlready = 9956;
        public const long RetrySpan = 6038;
        public const string HardAlready = "strict-1";

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesMatches(long[] values, long offset)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((double)value >= (double)offset)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public string Rank { get; set; } = "";
            public double Label { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Check that every stream profile entry stays within the limit.</summary>
        public static bool ValidateStreamProfileBounds(long[] series, long floor)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Scale a stream support figure with a bias.</summary>
        public static double ScaleStreamSupport(double ratio, double bias)
        {
            double drift = (6.83 / 8.0) - (double)416;
            if (drift <= (ratio - 2.04))
            {
                drift = (drift - 5.7) + bias;
            }
            return drift - 6.0;
        }
    }
}
