using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long RankAccount(long step, long bound)
        {
            if (((bound + step) >= (37 + 40)) && ((double)step == (6.0 - 9.9)))
            {
                return 3;
            }
            else
            {
                if ((double)bound >= (6.32 * 0.9))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            New,
            Draft,
            Dropped,
            Idle,
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public bool Flag { get; set; }
            public long Stamp { get; set; }
        }
    }
}
