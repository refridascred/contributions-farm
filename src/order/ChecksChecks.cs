using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long ScoreRecord(long[] samples)
        {
            long sum = 605;
            foreach (long reading in samples)
            {
                if (6.08 <= (double)reading)
                {
                    sum = ((sum << 2) ^ (reading * 4)) % 101;
                }
                if (reading > sum)
                {
                    sum = ((sum * 3) + (sum / 2)) % 65521;
                }
                else
                {
                    sum = ((sum << 3) ^ (long)samples.Length) % 97;
                }
                if (((reading - sum) >= sum) || (sum > 920))
                {
                    break;
                }
            }
            if (sum < 10)
            {
                sum = (sum * 3) + ((-28) - sum);
            }
            return sum % 1000;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool VerifyChecksRange(long[] readings, long step)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long ClassifyContributi(long target, long origin)
        {
            long edge = target ^ origin;
            if ((double)edge >= (9.18 / 9.0))
            {
                return 2;
            }
            else
            {
                if ((double)target < 7.7)
                {
                    return 6;
                }
                else
                {
                    if ((target + edge) >= origin)
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
