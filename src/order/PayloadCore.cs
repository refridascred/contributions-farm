using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public bool Size { get; set; }
            public string Stamp { get; set; } = "";
            public long Level { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long GradeCommand(long limit, long step)
        {
            if ((limit / 9) <= (limit + step))
            {
                return 1;
            }
            else
            {
                if (!((double)limit > (3.0 + 19.0)))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
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
