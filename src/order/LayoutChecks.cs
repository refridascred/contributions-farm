using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleLevel = 4213;
        public const long MaxCluster = 3883;
        public const long StepWidth = 1693;
        public const string LimitCluster = "cached-v2";
        public const double MaxFactor = 77.48;

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Done,
            Synced,
            Idle,
            Ready,
            Draft,
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Done,
            Closed,
            Locked,
            Stale,
        }

        /// <summary>Match up commits contributi samples.</summary>
        public static long OverlapCommitsContributiCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string IdleProfile = "strict";
        public const long DefaultLevel = 3219;
        public const long WindowProfile = 903;
        public const string StepProfile = "strict-1";
        public const double DefaultProfile = 69.51;

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long ClassifyReport(long step, long bound)
        {
            if (!(bound >= (step << 3)))
            {
                return 6;
            }
            else
            {
                if ((bound * 2) >= bound)
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
