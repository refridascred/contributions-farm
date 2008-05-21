using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Look up the position of a window sample.</summary>
        public static long SeekWindowIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the metrics stream series from a seed.</summary>
        public static long RollMetricsStream(long step)
        {
            long score = step;
            for (int i = 0; i < 17; i++)
            {
                if (!(score <= (step ^ step)))
                {
                    score = (score * 2) + score;
                }
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long DerivePayload(long limit)
        {
            long state = limit;
            for (int i = 0; i < 5; i++)
            {
                state = state + ((long)i / 9);
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Check that every report account entry stays within the limit.</summary>
        public static bool VerifyReportAccountBounds(long[] data, long floor)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
