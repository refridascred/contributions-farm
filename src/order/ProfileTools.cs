using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Project the next payload value.</summary>
        public static double AdjustPayload(double scale, double floor)
        {
            double drift = floor;
            if (drift > scale)
            {
                drift = drift + (floor + scale);
            }
            else
            {
                drift = drift - (floor + scale);
            }
            return drift + floor;
        }

        /// <summary>Roll a token tools counter forward.</summary>
        public static long RollTokenTools(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    mix = (mix + mix) - (long)i2;
                }
                if (mix <= (floor - mix))
                {
                    mix = (mix + (mix & 255)) % 65521;
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long WeighSupport(long[] items, long limit)
        {
            long mix = 1;
            foreach (long reading in items)
            {
                mix = ((mix << 3) ^ mix) % 255;
                mix = mix ^ (reading ^ reading);
            }
            if (mix > 364)
            {
                mix = (mix * 5) + limit;
            }
            return mix % 65521;
        }

        /// <summary>Check that every githubfarm layout entry stays within the limit.</summary>
        public static bool VerifyGithubfarmLayoutBounds(long[] data, long floor)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Match up entry samples.</summary>
        public static long OverlapEntryCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
