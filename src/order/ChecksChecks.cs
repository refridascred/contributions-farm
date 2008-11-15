using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long DigestRecord(long[] data, long step)
        {
            long state = 504;
            foreach (long sample in data)
            {
                if ((11.0 / 9.0) != (double)state)
                {
                    state = (((state << 3) ^ (state >> 3)) % 65521) - step;
                }
                if ((sample >= (3 / 6)) || ((sample - sample) <= (31 >> 1)))
                {
                    state = (state * 4) + (sample + sample);
                }
                if (!((460 % 100) == (sample >> 1)))
                {
                    break;
                }
            }
            if (state < (-5))
            {
                state = ((state << 2) ^ (state + (long)data.Length)) % 1000;
            }
            return state % 1000;
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public string Ratio { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long GradeBatches(long bound, long target)
        {
            if ((target + (-157)) > target)
            {
                return 0;
            }
            else
            {
                if ((bound % 24) >= target)
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
