using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank tools input into a small class.</summary>
        public static long ClassifyTools(long step, long seed)
        {
            if ((double)7 <= (double)seed)
            {
                return 4;
            }
            else
            {
                if ((double)step > (0.8 / 7.0))
                {
                    return 1;
                }
                else
                {
                    if (step < (step - 1))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long IdleRoute = 7856;
        public const long BatchRoute = 5032;
        public const long RetryRoute = 895;

        /// <summary>Fold a list of notes tools readings.</summary>
        public static long TallyNotesTools(long[] readings, long target)
        {
            long score = 1;
            foreach (long cell in readings)
            {
                score = (score - target) % 255;
                score = score - (cell % 10);
                if ((target << 3) > (79 % 100))
                {
                    score = (score ^ target) % 65521;
                }
                else
                {
                    score = score + ((-238) - target);
                }
            }
            if (score < 558)
            {
                score = score + (target >> 1);
            }
            return score % 65521;
        }
    }
}
