# Episode 6 — Farewell, Stardew Valley

**Wednesday–Thursday, December 4–5, 2024**  
**Theme:** A successful rescue can still alert the wrong people.

## Cold Open — The Final Countdown

### Scene 1 — Station 07 · 4:26 A.M.

The underground terminal reports failing containment and critically low backup power.

```text
CONTAINMENT INTEGRITY: 12%
EXTERNAL CONTROL NODE 12: OFFLINE
BACKUP POWER: CRITICAL
ESTIMATED TIME TO FAILURE: 09:34:18
```

A maintenance robot attempts to replace a damaged module. Sparks fly.

```text
REPAIR FAILED
REPLACEMENT COMPONENT MISSING
```

**SYSTEM:** REQUESTING HUMAN ASSISTANCE.

**CUT TO OPENING.**

## Act I — The Last Morning

### Scene 2 — Ko Estate Breakfast · 7:15 A.M.

Snow drifts past the windows. Breakfast shares the table with electronic equipment.

**SAPPHIRE FOX:** I said no circuit boards on the dining table.

**AETHER GEAR:** I cleaned this one.

**SAPPHIRE FOX:** Still no.

He moves it.

**NATALICA:** Dad lost again.

**AETHER GEAR:** I respect the household chain of command.

**CARRIE:** Mom is the commanding officer.

Sapphire Fox announces that the family will leave after the investigation.

**NATALICA:** But I haven't even visited the desert!

**SAPPHIRE FOX:** We're in Washington, not touring the planet.

**AETHER GEAR:** Technically, there's a bus—

**SAPPHIRE FOX:** Don't.

She turns serious.

**SAPPHIRE FOX:** Today we follow the plan. Especially you.

**AETHER GEAR:** Me?

**SAPPHIRE FOX:** You nearly connected a diagnostic cable to an unknown system yesterday.

**AETHER GEAR:** Nearly.

**SAPPHIRE FOX:** Because I stopped you.

### Scene 3 — The Farm · 8:40 A.M.

Carrie and Natalica invite the farmer to Ko Estate for one last assignment.

**FARMER:** Last one?

**CARRIE:** We're heading back to Southern California tomorrow.

**NATALICA:** I think it's too soon!

The farmer reads a note marked **For Our Most Reliable Friend in Stardew Valley** and agrees to help.

## Act II — One Last Favor

### Scene 4 — Ko Estate Workshop · 10:05 A.M.

Aether Gear explains that the recovered silver fragment is a communication-and-synchronization module. It belongs in Remote Node 12.

**NATALICA:** So we just put it back?

**AETHER GEAR:** In theory.

**SAPPHIRE FOX:** I dislike those two words.

The plan: the farmer guides the team; Aether Gear performs isolated diagnostics and the repair; Carrie handles communications; Sapphire Fox manages field safety; Natalica monitors the system from the estate.

**NATALICA:** Again with the monitors!

**AETHER GEAR:** You're good at them.

**NATALICA:** Then I want to use your workstation when we get home.

**AETHER GEAR:** Absolutely not.

### In-Game Quest Concept — Quest 04: One Last Favor

> **Objectives:** Meet Aether Gear; escort the team to Remote Node 12; assist with restoring communication; return to Ko Estate.  
> **Reward:** 5,000g, **Ko Family Field Monitor**, and a permanent Ko family friendship event.  
> **Status:** Planned final story quest; not implemented in v0.8.6-beta.

## Act III — Restoring the Network

### Scene 5 — Remote Node 12 · 12:18 P.M.

The farmer leads the team up the old trail. At the metal box, Aether Gear finds an empty communication-module socket.

**CARRIE:** Does the fragment fit there?

**AETHER GEAR:** Exactly. But first we verify power, pins, and isolation.

**SAPPHIRE FOX:** Good. Caution suits you.

**AETHER GEAR:** It helps when someone is watching every move I make.

**SAPPHIRE FOX:** You're welcome.

After testing, Aether Gear seats the module. The indicator lights come on.

```text
REMOTE NODE 12
COMMUNICATION MODULE DETECTED
HARDWARE SELF-TEST: PASS
NETWORK SYNCHRONIZATION: PENDING
```

He starts synchronization.

```text
STATION 07 — CONNECTED
CONTAINMENT NETWORK — RECOVERING
INTEGRITY: 12% → 28% → 47% → 63% → 79% → 91%
```

**NATALICA (over radio):** Dad! The numbers are going up!

**CARRIE:** We did it!

Sapphire Fox is watching a different log.

**SAPPHIRE FOX:** Not quite. The node is sending data outside the valley.

```text
EXTERNAL UPLINK — ACTIVE
DESTINATION: UNKNOWN
TRANSMITTING:
STATION LOCATION
CONTAINMENT STATUS
TARGET SIGNATURE
```

Aether Gear's smile disappears.

**AETHER GEAR:** We restored containment—and may have reopened a tracking channel.

## Act IV — The Choice

### Scene 6 — Remote Node 12 · 12:47 P.M.

Aether Gear checks whether the internal containment bus can operate independently of the external telemetry link.

```text
INTERNAL CONTAINMENT BUS: ACTIVE
EXTERNAL TELEMETRY UPLINK: ACTIVE
NETWORK SEGMENTATION: CONFIRMED
```

**CARRIE:** Can you disconnect the outside link without shutting down containment?

**AETHER GEAR:** Yes. The networks are separate.

**SAPPHIRE FOX:** Then disconnect it.

**AETHER GEAR:** If there is a legitimate remote operator—

**SAPPHIRE FOX:** A legitimate operator wouldn't leave a secret underground system unattended until its containment failed. We don't know who's receiving those coordinates.

Aether Gear considers her argument, then disables external telemetry.

```text
EXTERNAL UPLINK: DISABLED
INTERNAL CONTAINMENT: ACTIVE
INTEGRITY: 96%
LOCAL AUTONOMOUS MODE ENABLED
NEXT MAINTENANCE CYCLE: 180 DAYS
```

The mountain falls quiet.

**CARRIE:** Is it really over?

**AETHER GEAR:** Stable for now. That doesn't mean we've solved every mystery.

**NATALICA (over radio):** Does that mean we can have a party?

**SAPPHIRE FOX:** All that child thinks about is food and fun.

**AETHER GEAR (quietly):** A party sounds pretty good.

**SAPPHIRE FOX:** I heard that.

## Act V — The Farmer's Gift

### Scene 7 — Ko Estate Dinner · 6:20 P.M.

The family invites the farmer to dinner. Natalica asks about Skull Cavern and how deep the farmer has traveled.

**NATALICA:** Next time, we're going to the desert!

**AETHER GEAR:** We'll see.

**SAPPHIRE FOX:** There is no next time.

Carrie grins. Aether Gear brings out a small metal device engraved with the Ko family emblem.

**AETHER GEAR:** A portable environmental monitor. Temperature, pressure, and other readings. I thought it might be useful around the farm.

Carrie offers a handwritten card signed by the family. Natalica has drawn a slime wearing a military cap.

**FARMER:** What's this?

**NATALICA:** Combat Slime!

Sapphire Fox extends her hand.

**SAPPHIRE FOX:** I was suspicious of you at first. Your methods are... unusual. But you're reliable, and you know when to take a risk and when to retreat. Thank you for looking after my family.

**FARMER:** I'm glad I could help.

**AETHER GEAR (to Carrie):** Your mother finally approves of the farmer.

**SAPPHIRE FOX:** I can hear you.

### Narrative Reward — Quest Complete

```text
ONE LAST FAVOR — COMPLETE
GOLD REWARD: 5,000g
SPECIAL ITEM: KO FAMILY FIELD MONITOR
FRIENDSHIP: KO FAMILY — TRUSTED FRIEND
```

*Design concept for a future mod release; not yet implemented.*

## Epilogue — Goodbye, Stardew Valley

### Scene 8 — Ko Estate · Thursday, December 5 · 9:30 A.M.

The family loads the car. Carrie looks back toward the forest.

**CARRIE:** I'm going to miss this place.

**NATALICA:** Are we coming back next year?

**AETHER GEAR:** Maybe.

**NATALICA:** That's a promise!

**AETHER GEAR:** That's not what I said!

The farmer arrives carrying a basket of produce, jam, and a letter.

**FARMER:** For the road.

**SAPPHIRE FOX:** Thank you. That's very kind.

Natalica hugs the farmer.

**NATALICA:** We'll be back!

**CARRIE:** And if you ever visit Southern California, let us know.

**AETHER GEAR:** If that monitor shows anything strange, please don't investigate alone.

**FARMER:** I'll try.

**SAPPHIRE FOX:** Not “try.” Promise.

The family drives away along the Backwoods road. Natalica waves from the window.

**NATALICA:** BYE-BYE, STARDEW VALLEY!

**SAPPHIRE FOX:** Natalica! Head inside the car!

### Scene 9 — On the Road South

Natalica sleeps in the back seat. Carrie watches the trees roll by. Sapphire Fox flips through her notes.

**SAPPHIRE FOX:** I still don't understand how you and the girls knew so much about that town before we arrived.

**AETHER GEAR:** I told you. I introduced them to the Stardew Valley game.

**SAPPHIRE FOX:** Then explain one thing. Can that farmer really put a double bed in a backpack?

**AETHER GEAR:** Yes.

Sapphire Fox turns slowly.

**SAPPHIRE FOX:** You knew that all along?!

Carrie bursts out laughing. Natalica wakes with a start.

**NATALICA:** Are we at the desert yet?

**SAPPHIRE FOX:** We're going home!

The car follows the highway south through the mountains.

## Post-Credits — The Signal Was Received

### Scene 10 — Unknown Control Room · December 5 · Night

An operator watches a map of the American West. A marker flashes over Washington State.

```text
STATION 07
LOCAL CONTAINMENT RESTORED
EXTERNAL UPLINK TERMINATED
LAST KNOWN INTERFERENCE: KO FAMILY
```

**UNKNOWN FIGURE:** Who severed our connection?

**OPERATOR:** We're confirming identities. Several people match personnel associated with the Southern California incident.

```text
PERSONS OF INTEREST:
AETHER GEAR
SAPPHIRE FOX
CARRIE KO
NATALICA KO
```

**UNKNOWN FIGURE:** The Ko family...

The display shifts to Southern California. Several red markers light up.

**UNKNOWN FIGURE:** If they know Station 07 exists, we can't let them continue their investigation.

```text
PROJECT STATUS: PHASE TWO — AUTHORIZED
NEXT OPERATIONAL AREA: SOUTHERN CALIFORNIA
```

**CUT TO BLACK.**

**THE STARDEW VALLEY INCIDENT — END**
