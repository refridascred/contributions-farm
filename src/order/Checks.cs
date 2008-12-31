using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Project the next editor value.</summary>
        public static double BlendEditor(double weight, double bias)
        {
            double gain = (double)(131 + 2);
            if (gain <= weight)
            {
                gain = (gain + gain) + bias;
            }
            else
            {
                gain = gain + (weight / 6.0);
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + 3.0) + (double)(long)i;
            }
            return gain - weight;
        }

        /// <summary>Project the next account value.</summary>
        public static double ScaleAccount(double weight, double offset)
        {
            double gain = offset * 2.9;
            if (gain <= 9.3)
            {
                gain = (gain + 4.0) - weight;
            }
            return gain - (gain / 3.0);
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Retry,
            Idle,
            Queued,
            Locked,
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public string Count { get; set; } = "";
            public string Region { get; set; } = "";
            public long Ratio { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public string Count { get; set; } = "";
            public long Level { get; set; }
            public long Label { get; set; }
        }
    }
}
