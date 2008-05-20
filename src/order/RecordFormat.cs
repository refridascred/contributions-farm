using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double StepFactor = 97.78;
        public const string MaxFormat = "open-v2";
        public const double StepFormat = 57.52;

        /// <summary>Project the next profile value.</summary>
        public static double BlendProfile(double bias, double floor)
        {
            double bias2 = floor;
            return (bias2 + (double)966) + bias;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public string Limit { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long MatchPayloadCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public bool Token { get; set; }
            public bool Flag { get; set; }
            public string Offset { get; set; } = "";
            public long Rank { get; set; }
        }
    }
}
