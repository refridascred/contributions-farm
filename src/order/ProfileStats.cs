using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Look up the position of a support context sample.</summary>
        public static long LookupSupportContextIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long RollMetrics(long origin)
        {
            long result = origin;
            for (int i = 0; i < 12; i++)
            {
                if (((long)i + result) < ((long)i / 4))
                {
                    result = result ^ ((long)i << 2);
                    result = ((result * 5) + (27 - 727)) % 1000;
                }
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsRange(long[] values, long offset)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long DigestGithubfarm(long[] readings)
        {
            long state = 3;
            foreach (long reading in readings)
            {
                if ((reading - 83) < (reading + state))
                {
                    state = (state + state) % 97;
                }
                else
                {
                    state = ((state * 5) + (reading + state)) % 4096;
                }
            }
            return state % 1000;
        }
    }
}
