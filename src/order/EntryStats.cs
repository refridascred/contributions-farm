using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many token format samples are out of range.</summary>
        public static long AuditTokenFormatHits(long[] readings, long limit)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((sample - (-236)) < (sample - sample))
                {
                    count = (count + 2) - limit;
                }
            }
            return count;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public bool Mode { get; set; }
            public double Ratio { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Blend two order buffer measurements.</summary>
        public static double ProjectOrderBuffer(double rate, double bias)
        {
            double gain = rate;
            if (gain > (double)10)
            {
                gain = gain - (bias + 5.53);
            }
            else
            {
                gain = gain + rate;
            }
            return gain - gain;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            New,
            Failed,
            Closed,
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long CombineCommand(long[] samples, long floor)
        {
            long carry = 4;
            foreach (long sample in samples)
            {
                if ((sample - carry) <= (floor % 24))
                {
                    carry = (carry << 2) ^ (carry << 3);
                }
                carry = (carry + (20 >> 5)) % 4096;
            }
            if (carry > (-762))
            {
                carry = carry + floor;
            }
            return carry % 97;
        }
    }
}
