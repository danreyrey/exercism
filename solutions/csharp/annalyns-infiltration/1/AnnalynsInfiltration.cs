static class QuestLogic
{
    public static bool CanFastAttack(bool knightIsAwake)
    {
        if (knightIsAwake)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
    {
        if (knightIsAwake || archerIsAwake || prisonerIsAwake)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
    {
        if (!archerIsAwake && prisonerIsAwake)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {
        if (knightIsAwake && !archerIsAwake && (prisonerIsAwake || !prisonerIsAwake) && petDogIsPresent)
        {
            return true;
        }
        else if (!knightIsAwake && !archerIsAwake && prisonerIsAwake && petDogIsPresent)
        {
            return true;
        }
        else if (!knightIsAwake && !archerIsAwake && !prisonerIsAwake && !petDogIsPresent)
        {
            return false;
        }
        else if (!knightIsAwake && !archerIsAwake && !prisonerIsAwake && petDogIsPresent)
        {
            return true;
        }
        else if (!knightIsAwake && !archerIsAwake && prisonerIsAwake && !petDogIsPresent)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
