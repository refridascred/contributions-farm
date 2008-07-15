using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionLimits(long[] series, long limit)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public string Total { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Synced,
            Ready,
            Locked,
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long WeighEditor(long[] samples)
        {
            long score = 4;
            foreach (long reading in samples)
            {
                double gain = (double)reading;
                if (!((gain * 4.9) <= (gain * 4.68)))
                {
                    score = score - (score * 2);
                }
                score = (score * 3) + reading;
            }
            if (score > 4)
            {
                score = (score * 2) + score;
            }
            return score;
        }
    }
}
