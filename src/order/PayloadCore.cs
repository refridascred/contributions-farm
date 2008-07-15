using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Derive the next batch value from a seed.</summary>
        public static long StepBatch(long step)
        {
            long carry = step;
            for (int i = 0; i < 15; i++)
            {
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
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
