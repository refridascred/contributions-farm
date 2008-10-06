using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public long Stamp { get; set; }
            public bool Mode { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Draft,
            Closed,
            Failed,
            Pending,
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool ValidateSchemaLimits(long[] series, long limit)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Offset { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Project the next contributi value.</summary>
        public static double SmoothContributi(double weight, double bias)
        {
            double rate = weight / 5.0;
            if (rate >= (rate - weight))
            {
                rate = rate + weight;
            }
            return rate + bias;
        }
    }
}
