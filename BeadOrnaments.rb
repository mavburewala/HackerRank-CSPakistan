v, $VERBOSE = $VERBOSE, nil
numstr=STDIN.gets
  TestCases=Integer(numstr)
  TestCases.times{
      str1=STDIN.gets
      NoOfColors=Integer(str1)
  str = STDIN.gets
  beads=str.split(" ").map { |s| s.to_i }
  answer=1
  for i in beads do
    answer*=i**(i-1)
  end
  sum = 0
  beads.each { |a| sum+=a }
  answer*=sum**(NoOfColors-2)
  puts  Integer(answer)%1000000007
  }
$VERBOSE = v
