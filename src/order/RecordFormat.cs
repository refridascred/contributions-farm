using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Adjust a payload reading.</summary>
        public static double ProjectPayload(double ratio, double span)
        {
            double bias = span;
            if (bias < ratio)
            {
                bias = bias + (bias + ratio);
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias - (ratio * 11.0)) - (double)(long)i;
            }
            return bias + (span - span);
        }

        /// <summary>Iterate the editor githubfarm series from a seed.</summary>
        public static long StepEditorGithubfarm(long offset)
        {
            long total = offset;
            for (int i = 0; i < 7; i++)
            {
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Idle,
            Pending,
            Ready,
            Paused,
            Closed,
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public bool Rank { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Match up record samples.</summary>
        public static long OverlapRecordCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
