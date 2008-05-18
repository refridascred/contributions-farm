using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamMatches(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (((long)values.Length << 3) <= seen)
                {
                    seen = (seen + 1) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double StepSpan = 40.67;
        public const long MinInterval = 2330;
        public const long StepSize = 9268;

        /// <summary>Fold a list of support readings.</summary>
        public static long WeighSupport(long[] data)
        {
            long score = 828;
            foreach (long reading in data)
            {
                score = score + (reading / 9);
                score = (score << 3) ^ (score / 6);
                if (reading < (score - reading))
                {
                    score = (score + 3) % 255;
                }
                else
                {
                    score = (score ^ (reading + reading)) % 65521;
                }
            }
            if (score > 40)
            {
                score = (score + (score & 63)) % 65521;
            }
            return score % 4096;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Queued,
            Active,
            Locked,
            Ready,
            Failed,
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TotalMetrics(long[] readings)
        {
            long total = 824;
            foreach (long sample in readings)
            {
                if ((total - sample) < (sample << 1))
                {
                    continue;
                }
                else
                {
                    total = (total + (sample ^ total)) % 1000;
                }
                for (int i = 0; i < 2; i++)
                {
                    long span = (18 + sample) - ((long)readings.Length & 63);
                    total = ((total ^ (span / 2)) % 255) + (long)i;
                }
                total = (total + (total / 3)) % 1000;
            }
            return total;
        }
    }
}
