//TC: O(M x N)
//SC: O(M x N)
public class Solution {
    public int CoinChange(int[] coins, int amount) {
        
        int m = coins.Length;
        int n = amount;
        int[,] dp = new int[m+1,n+1];
        
        for(int j=1;j<=n;j++){
            dp[0,j] = amount+2;
        }
        
        for(int i= 1;i<=m;i++){
            for(int j=1;j<=n;j++){
                if(j<coins[i-1]){
                    dp[i,j] = dp[i-1,j];
                }else{
                    dp[i,j] = Math.Min(dp[i-1,j],1+dp[i,j-coins[i-1]]);
                }            
            }   
        }
        
        int result = dp[m,n];
        
        if(result>amount+1){
            return -1;
        }
        
        return result;
    }
}public class Solution {
    public int CoinChange(int[] coins, int amount) {
        
        int m = coins.Length;
        int n = amount;
        int[,] dp = new int[m+1,n+1];
        
        for(int j=1;j<=n;j++){
            dp[0,j] = amount+2;
        }
        
        for(int i= 1;i<=m;i++){
            for(int j=1;j<=n;j++){
                if(j<coins[i-1]){
                    dp[i,j] = dp[i-1,j];
                }else{
                    dp[i,j] = Math.Min(dp[i-1,j],1+dp[i,j-coins[i-1]]);
                }            
            }   
        }
        
        int result = dp[m,n];
        
        if(result>amount+1){
            return -1;
        }
        
        return result;
    }
}