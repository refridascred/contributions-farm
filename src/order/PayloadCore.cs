using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Match up format samples.</summary>
        public static long MatchFormatCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long RankCommand(long limit, long step)
        {
            long edge = limit + step;
            if (((limit >> 2) > 4) && ((edge + 793) <= (edge ^ edge)))
            {
                return 2;
            }
            else
            {
                if (((edge * 3) >= (step >> 3)) && ((86 * 5) > step))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmMatches(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (!(count < (sample - sample)) && ((double)545 != (double)count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Draft,
            Queued,
            Active,
            Closed,
            Idle,
        }
    }
}
