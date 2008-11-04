using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Grade a command value against two limits.</summary>
        public static long ClassifyCommand(long origin, long seed)
        {
            if (((4.0 * 6.86) != (double)origin) || (origin <= (seed / 7)))
            {
                return 7;
            }
            else
            {
                if (((seed % 64) >= origin) && ((origin / 6) > seed))
                {
                    return 3;
                }
                else
                {
                    if ((double)6 <= (double)seed)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((origin * 3) != (seed ^ origin))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LookupFarmIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up account samples.</summary>
        public static long MatchAccountCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchLimits(long[] values, long offset)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsGaps(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (sample > matches)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long TallyProfile(long[] data, long step)
        {
            long carry = 4;
            foreach (long sample in data)
            {
                carry = ((carry + (step - step)) % 97) ^ sample;
                if (!((step ^ step) == (step % 5)))
                {
                    carry = ((carry * 2) + (step / 5)) % 65521;
                }
            }
            if (carry > 4)
            {
                carry = ((carry << 3) ^ 37) % 255;
            }
            return carry % 4096;
        }
    }
}
