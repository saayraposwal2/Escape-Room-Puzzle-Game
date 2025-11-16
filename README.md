**Forgotten Fortress** — A 2D Language-Decoding Puzzle Adventure

A mystery-driven 2D puzzle game about deciphering a lost culture’s language through observation, inference, and environmental clues.

🎮 Overview

This game is a narrative puzzle experience where the player gradually uncovers the meaning of an ancient symbolic language.
You explore hand-crafted environments, interact with inscriptions, and update a dynamic Journal System that tracks every discovered glyph and meaning guess.

The goal is to interpret the symbols well enough to unlock new areas, understand the culture that built them, and ultimately reveal the truth behind their forgotten civilization.

✨ Key Features
🧩 Language-Based Puzzle System

Discover inscriptions and symbols scattered across the environment

Use context clues to infer their meaning

Combine previously learned glyphs with new information to solve puzzles

📖 Dynamic Player Journal

Automatically updates with newly discovered symbols

Displays guesses, confirmed meanings, and discovered connections

Implemented through multiple interconnected MonoBehaviour scripts calling each other to update pages, reveal snippets, and animate transitions

Includes narrative fragments that unlock as the Journal grows

🎨 2D Exploration

Navigate atmospheric locations inspired by ancient architectural motifs

Interact with environmental objects that reinforce the cultural logic of the world

Clean, readable UI optimized for deciphering symbols and clues

🔄 Modular Script Architecture

Journal UI, symbol discovery, interaction, and puzzle logic are distributed across multiple scripts

Each system communicates with others through events, function calls, and shared data objects

Designed for easy expansion with new puzzles, areas, or glyph families

🌐 Play the Game

👉 Itch.io link: https://spagettbro.itch.io/forgotten-fortress

🔍 Gameplay Flowchart

Below is a simple flowchart describing how the core gameplay loop works:

            ┌─────────────────────────┐
            │   Explore Environment   │
            └─────────────┬──────────┘
                          ▼
        ┌──────────────────────────────────┐
        │  Discover Symbol / Inscription   │
        └───────────────────┬─────────────┘
                            ▼
              ┌─────────────────────────┐
              │   Add Entry to Journal  │
              │  (New glyph or context) │
              └─────────────┬──────────┘
                            ▼
        ┌──────────────────────────────────┐
        │   Player Infers Meaning Through  │
        │   Clues, Context, and Patterns   │
        └───────────────────┬─────────────┘
                            ▼
        ┌──────────────────────────────────┐
        │   Journal Updates Meaning Guess   │
        │ (Triggers narrative snippets)     │
        └───────────────────┬─────────────┘
                            ▼
            ┌─────────────────────────┐
            │     Solve Puzzle        │
            │ (Using interpreted data)│
            └─────────────┬──────────┘
                          ▼
              ┌─────────────────────────┐
              │   Unlock New Area       │
              └─────────────┬──────────┘
                            ▼
            ┌─────────────────────────┐
            │    Continue Exploring    │
            └─────────────────────────┘
📝 License
MIT License
