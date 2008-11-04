using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Adjust a account metric reading.</summary>
        public static double BlendAccountMetric(double gain, double floor)
        {
            double weight = floor;
            return (weight + (double)12) + gain;
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Retry,
            Pending,
            Draft,
        }

        /// <summary>Match up account samples.</summary>
        public static long MatchAccountCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Offset { get; set; }
            public long Stamp { get; set; }
            public bool Limit { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsGaps(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (sample > matches)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of payload order entries.</summary>
        public static long DigestPayloadOrder(long[] levels)
        {
            long anchor = 82;
            foreach (long item in levels)
            {
                if (anchor < (anchor - anchor))
                {
                    anchor = (anchor ^ item) % 101;
                }
            }
            return anchor;
        }
    }
}
