def main():
  word = input("Enter a word: ")
  word = word.lower()
  count = 0
  for lcv in range(0, len(word) - 1):
    if word[lcv] == word[lcv + 1]:
      count += 1
  print(f"The word '{word}' contains {count} double letters")
  pass


if __name__ == "__main__":
  main()
